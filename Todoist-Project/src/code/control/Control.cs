﻿using OpenQA.Selenium;
using Todoist_Project.src.code.session;

namespace Todoist_Project.src.code.control
{
    public class Control
    {
        protected By locator;
        protected IWebElement control;
        protected IWebDriver iframe;


        public Control(By locator)
        {
            this.locator = locator;
            iframe = Session.Instance().GetBrowser();
            iframe.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        protected void FindControl()
        {
            Thread.Sleep(800);
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click()
        {
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
