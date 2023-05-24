using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Todoist_Project.src.code.control
{
    public class Button : Control
    {
        public Button(By locator) : base(locator)
        {
        }

        public void mouseOver()
        {
            FindControl();
            Actions actions = new Actions(session.Session.Instance().GetBrowser());
            actions.MoveToElement(control).Perform();
        }
    }
}
