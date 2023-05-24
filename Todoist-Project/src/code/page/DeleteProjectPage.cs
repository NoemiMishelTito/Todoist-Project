using OpenQA.Selenium;
using Todoist_Project.src.code.control;

namespace Todoist_Project.src.code.page
{
    public class DeleteProjectPage
    {
        public Button openExistingProject = new Button(By.XPath("(//ul[@id='projects_list']/li//span[text()='Project-Mojix-Edit'])[last()]"));
        public Button clickMenu = new Button(By.XPath("//button[@aria-label='Project options menu']"));
        public Button deleteBtn = new Button(By.XPath("//div[text()='Delete project']"));
        public Button deleteConfirmBtn = new Button(By.XPath("//button[span[text()='Delete']]"));

        public void OpenExistingProjectField()
        {
            openExistingProject.Click();
        }

        public void DeleteExistingProject()
        {
            clickMenu.mouseOver();
            clickMenu.Click();
            deleteBtn.mouseOver();
            deleteBtn.Click();
            deleteConfirmBtn.mouseOver();
            deleteConfirmBtn.Click();
            Thread.Sleep(2000);
        }
    }
}
