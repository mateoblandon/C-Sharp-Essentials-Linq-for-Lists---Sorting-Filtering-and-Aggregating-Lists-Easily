using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqLibrary;

namespace FormUI
{
  public partial class linq101DemoForm : Form
  {
    List<Person> people = ListManager.LoadSampleData();
    public linq101DemoForm()
    {
      InitializeComponent();
      InitializeBindings();
    }

    private void InitializeBindings()
    {
      allPeopleCombobox.DataSource = people;
      allPeopleCombobox.DisplayMember = "FullName";
      filteredListListbox.DataSource = people.Where(x => x.YearsExperience >= 5).ToList();
      filteredListListbox.DisplayMember = "FullName";
    }

    private void UpdateBindings()
    {
      filteredListListbox.DataSource = people.Where(x => x.YearsExperience >= 5).ToList();
    }

    private void allPeopleCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      Person selectedPerson = allPeopleCombobox.SelectedItem as Person;
      yearsExperienceNumericupdown.Value = selectedPerson.YearsExperience;
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
      Person selectedPerson = (Person)allPeopleCombobox.SelectedItem;
      selectedPerson.YearsExperience = Convert.ToInt32(yearsExperienceNumericupdown.Value);
      UpdateBindings();
    }
  }
}
