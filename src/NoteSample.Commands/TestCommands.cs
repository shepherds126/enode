﻿using ENode.Commanding;

namespace NoteSample.Commands
{
    public class TestEventPriorityCommand : Command<string>
    {
    }
    public class ChangeNothingCommand : Command<string>
    {
    }
    public class ThrowExceptionCommand : Command<string>
    {
    }
    public class NoHandlerCommand : Command<string>
    {
    }
    public class TwoHandlersCommand : Command<string>
    {
    }
    public class BaseCommand : Command<string>
    {
    }
    public class ChildCommand : BaseCommand
    {
    }
    public class AsyncHandlerBaseCommand : Command<string>
    {
    }
    public class AsyncHandlerChildCommand : AsyncHandlerBaseCommand
    {
    }

    public class AsyncHandlerCommand : Command<string>
    {
        public bool ShouldGenerateApplicationMessage { get; set; }
        public bool ShouldThrowException { get; set; }
        public bool ShouldThrowIOException { get; set; }
    }
    public class TwoAsyncHandlersCommand : Command<string>
    {
    }
    public class ChangeMultipleAggregatesCommand : Command<string>
    {
        public string AggregateRootId1 { get; set; }
        public string AggregateRootId2 { get; set; }
    }
    public class NotCheckAsyncHandlerExistCommand : Command<string>
    {
    }
    public class NotCheckAsyncHandlerExistWithResultCommand : Command<string>
    {
    }
}
