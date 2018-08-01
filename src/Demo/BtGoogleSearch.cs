﻿using System;
using BehaviourTree;
using BehaviourTree.Composites;
using BehaviourTree.InputBehaviours;
using InputSimulator;

namespace Demo
{
    public sealed class BtGoogleSearch : BtSubTree
    {
        public BtGoogleSearch(string search)
        {
            var behaviour =
                new BtSequence(
                    new BtOpenBrowser("foo", new Uri("https://www.google.com")),
                    new BtSendKeysToProcess("foo", search),
                    new BtSendKey(Key.Return)
                );

            SetBehaviour(behaviour);
        }
    }
}