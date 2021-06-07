﻿using Hasse.SharedKernel;

namespace Hasse.Core.ProjectAggregate.Events
{
    public class NewItemAddedEvent : BaseDomainEvent
    {
        public NewItemAddedEvent(Project project,
            ToDoItem newItem)
        {
            Project = project;
            NewItem = newItem;
        }

        public ToDoItem NewItem { get; set; }
        public Project Project { get; set; }
    }
}