﻿using JuliusSweetland.OptiKey.Enums;
using NUnit.Framework;
using System;

namespace JuliusSweetland.OptiKey.UnitTests.UI.ViewModels.MainViewModelSpecifications
{
    [TestFixture]
    public class WhenRaiseToastNotificationGivenToastNotificationEventHandler : MainViewModelTestBase
    {
        protected string Title => "dummy-title";
        protected string Content => "dummy-content";
        protected NotificationTypes NotificationType => NotificationTypes.Error;
        protected Action Callback => () => { };

        protected bool IsToastNotificationEventHandlerCalled { get; private set; }

        protected override void Arrange()
        {
            base.Arrange();
            MainViewModel.ToastNotification += (s, e) => IsToastNotificationEventHandlerCalled = true;
        }

        protected override void Act()
        {
            MainViewModel.RaiseToastNotification(Title, Content, NotificationType, Callback);
        }

        [Test]
        public void ThenToastNotificationEventHandlerShouldBeTriggered()
        {
            Assert.IsTrue(IsToastNotificationEventHandlerCalled);
        }
    }
}
