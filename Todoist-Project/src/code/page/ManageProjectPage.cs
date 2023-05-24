using OpenQA.Selenium;
using Todoist_Project.src.code.control;

namespace Todoist_Project.src.code.page
{
    public class ManageProjectPage
    {
        // Create Project locator
        public Button openProject = new Button(By.XPath("//a[@href='/app/projects']"));
        public Button addProject = new Button(By.XPath("//button[contains(span, 'Add project')]"));
        public Modal modalProject = new Modal(By.Id(":r12:"));
        // Selecciona el input siguiente al label usando el ID ((Ya que ambos tienen el mismo id))
        public TextBox nameProject = new TextBox(By.XPath("//label[@for='edit_project_modal_field_name']/following-sibling::input"));
        // Selecciona el button siguiente al label usando el ID (Ya que ambos tienen el mismo id)
        public Button opencolorPalette = new Button(By.XPath("//label[@id='edit_project_modal_field_color_label']/following-sibling::button"));
        public Button selectColor = new Button(By.CssSelector("#dropdown-select-0-option-red > .color_dropdown_select__name"));
        public Button addFavorite = new Button(By.XPath("//span[contains(@class, 'reactist_switch--handle')]"));
        public Button AddBtn = new Button(By.XPath("//button[span[text() = 'Add']]"));
  

        public void OpenProjectField()
        {
            openProject.Click();
        }

        public void ClickNewProject()
        {
            addProject.Click();
        }

        public void CreateNewProject(String namepro)
        {
            nameProject.SetText(namepro);
            opencolorPalette.Click();
            selectColor.mouseOver();
            selectColor.Click();
            addFavorite.mouseOver();
            addFavorite.Click();
            AddBtn.Click();
            Thread.Sleep(2000);
        }

        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id='projects_list']/li//span[text()='" + nameValue + "'])[last()]"));
            
            return nameProject.IsControlDisplayed();
        }
    }
}
