using OpenQA.Selenium;
using Todoist_Project.src.code.control;

namespace Todoist_Project.src.code.page
{
    public class EditProjectPage
    {
        public Button openExistingProject = new Button(By.XPath("(//ul[@id='projects_list']/li//span[text()='Project-Mojix'])[last()]"));
        public Button clickMenu = new Button(By.XPath("//button[@aria-label='Project options menu']"));
        public Button editBtn = new Button(By.XPath("//div[text()='Edit project']"));
        public TextBox nameProject = new TextBox(By.XPath("//label[@for='edit_project_modal_field_name']/following-sibling::input"));
        public Button SaveBtn = new Button(By.XPath("//button[span[text() = 'Save']]"));
        public Button addFavorite = new Button(By.XPath("//span[contains(@class, 'reactist_switch--handle')]"));



        public void OpenExistingProjectField()
        {
            openExistingProject.Click();
        }

        public void EditExistingProject(String editname)
        {
            clickMenu.mouseOver();
            clickMenu.Click();
            editBtn.mouseOver();
            editBtn.Click();
            nameProject.Clear();
            nameProject.SetText(editname);
            addFavorite.Click();
            SaveBtn.Click();
            Thread.Sleep(2000);
        }
    }
}
