﻿using System.Activities.Presentation.Model;
using System.Activities.Statements;
using System.Activities.Presentation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Dev2.Studio.Core.Activities.Utils;
using System.Activities.Presentation;
using Dev2;
using Dev2.Activities;
using Dev2.Studio.Interfaces;
using Dev2.Common;
using Dev2.Utilities;

namespace Warewolf.MergeParser
{
    public class ParseServiceForDifferences : IParseServiceForDifferences
    {
        private readonly IActivityParser _activityParser;
        public (List<ModelItem> nodeList, Flowchart flowchartDiff) CurrentDifferences { get; private set; }
        public (List<ModelItem> nodeList, Flowchart flowchartDiff) Differences { get; private set; }

        private ModelItem GetCurrentModelItemUniqueId(IEnumerable<IDev2Activity> items, IDev2Activity activity)
        {
            if (activity == null) return default;
            foreach (var modelItem in items)
                if (modelItem.UniqueID.Equals(activity.UniqueID))
                    return ModelItemUtils.CreateModelItem(modelItem);
            return default;
        }

        public ParseServiceForDifferences()
            : this(CustomContainer.Get<IActivityParser>())
        {

        }
        public ParseServiceForDifferences(IActivityParser activityParser)
        {
            VerifyArgument.IsNotNull(nameof(activityParser), activityParser);
            _activityParser = activityParser;
        }

        public (ModelItem current, ModelItem difference, List<KeyValuePair<Guid, bool>> differenceStore) GetDifferences(IContextualResourceModel current, IContextualResourceModel difference)
        {
            var conflictList = new List<(Guid uniqueId, ModelItem current, ModelItem difference, bool conflict)>();
            CurrentDifferences = GetNodes(current);
            Differences = GetNodes(difference);
            var parsedCurrent = GetActivity(CurrentDifferences.flowchartDiff);
            var parsedDifference = GetActivity(Differences.flowchartDiff);
            var equalItems = new List<IDev2Activity>();
            var flatCurrent = _activityParser.ParseToLinkedFlatList(parsedCurrent).ToList();
            var flatDifference = _activityParser.ParseToLinkedFlatList(parsedDifference).ToList();
            foreach (var mergeHeadActivity in flatCurrent)
            {
                var singleOrDefault = flatDifference.SingleOrDefault(activity => activity.Equals(mergeHeadActivity));
                if (singleOrDefault != null)
                    equalItems.Add(singleOrDefault);
            }

            var nodesDifferentInMergeHead = flatCurrent.Except(flatDifference, new Dev2ActivityComparer()).ToList();
          /*  var toRemove = new List<IDev2Activity>();

            foreach (var differentInMergeHead in nodesDifferentInMergeHead)
            {
                if (equalItems.Contains(differentInMergeHead, new Dev2ActivityComparer()))
                {
                    toRemove.Add(differentInMergeHead);
                }
            }

            nodesDifferentInMergeHead.RemoveAll(activity => toRemove.Exists(dev2Activity => dev2Activity.Equals(activity)));*/

            var nodesDifferentInHead = flatDifference.Except(flatCurrent, new Dev2ActivityComparer()).ToList();
           /* var toRemove1 = new List<IDev2Activity>();
            foreach (var differentInMergeHead in nodesDifferentInHead)
            {
                if (equalItems.Contains(differentInMergeHead))
                {
                    toRemove1.Add(differentInMergeHead);
                }
            }
            nodesDifferentInHead.RemoveAll(activity => toRemove1.Exists(dev2Activity => dev2Activity.Equals(activity)));*/

            var allDifferences = nodesDifferentInMergeHead.Union(nodesDifferentInHead, new Dev2ActivityComparer());

            foreach (var item in equalItems)
            {
                if (item is null)
                {
                    continue;
                }
                var currentModelItemUniqueId = GetCurrentModelItemUniqueId(flatCurrent, item);

                var equalItem = (Guid.Parse(item.UniqueID), currentModelItemUniqueId, currentModelItemUniqueId, false);
                conflictList.Add(equalItem);
            }

            var differenceGroups = allDifferences.GroupBy(activity => activity.UniqueID).DistinctBy(grouping => grouping.Key).ToList();
            foreach (var item in differenceGroups)
            {
                using (var enumerator = item.GetEnumerator())
                {
                    while (enumerator.MoveNext() && !conflictList.Any(tuple => tuple.uniqueId.ToString().Equals(item.Key)))
                    {
                        if (item.Key.Equals(enumerator.Current?.UniqueID))
                        {
                            var currentModelItemUniqueId = GetCurrentModelItemUniqueId(flatCurrent, enumerator.Current);
                            var differences = GetCurrentModelItemUniqueId(flatDifference, enumerator.Current);
                            var diffItem = (Guid.Parse(item.Key), currentModelItemUniqueId, differences, true);
                            conflictList.Add(diffItem);
                        }
                    }
                }
            }
            var keyValuePairs = conflictList.Select(p => new KeyValuePair<Guid, bool>(p.uniqueId, p.conflict)).ToList();
            var valueTuples = (ModelItemUtils.CreateModelItem(parsedCurrent), ModelItemUtils.CreateModelItem(parsedDifference), keyValuePairs);


            return valueTuples;
        }

        private IDev2Activity GetActivity(Flowchart modelItem)
        {
            var act = _activityParser.Parse(new List<IDev2Activity>(), modelItem);
            return act;
        }

        private (List<ModelItem> nodeList, Flowchart flowchartDiff) GetNodes(IContextualResourceModel resourceModel)
        {
            var wd = new WorkflowDesigner();
            var xaml = resourceModel.WorkflowXaml;

            var workspace = GlobalConstants.ServerWorkspaceID;
            var msg = resourceModel.Environment.ResourceRepository.FetchResourceDefinition(resourceModel.Environment, workspace, resourceModel.ID, false);
            if (msg != null)
            {
                xaml = msg.Message;
            }

            if (xaml == null || xaml.Length == 0)
            {
                throw new Exception($"Could not find resource definition for {resourceModel.ResourceName}");
            }
            wd.Text = xaml.ToString();
            wd.Load();

            var modelService = wd.Context.Services.GetService<ModelService>();
            var nodeList = modelService.Find(modelService.Root, typeof(FlowNode)).ToList();
            var workflowHelper = new WorkflowHelper();
            var flowchartDiff = workflowHelper.EnsureImplementation(modelService).Implementation as Flowchart;
            // ReSharper disable once RedundantAssignment assuming this is for disposing
            wd = null;
            return (nodeList, flowchartDiff);
        }

    }
}
