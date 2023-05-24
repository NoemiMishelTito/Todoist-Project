using OpenQA.Selenium;

namespace Todoist_Project.src.code.control
{
    public class TextBox : Control
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(String value) 
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }
        public void Clear()
        {
            FindControl();
            control.Clear();
        }

    }
}
