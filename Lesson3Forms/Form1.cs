using Lesson3Forms.Modelss;
using System.Text.Json;

namespace Lesson3Forms;

public partial class Form1 : Form
{
    List<Userr> userrs = new List<Userr>();

    public Form1()
    {
        InitializeComponent();
    }



    void Jsonwrite()
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string data = JsonSerializer.Serialize<List<Userr>>(userrs, options);
        File.WriteAllText($"../../../{name.Text}.json", data);
    }

    List<Userr> JSonread()
    {
        if (File.Exists($"../../../{name.Text}.json"))
        {
            string txt = File.ReadAllText($"../../../{name.Text}.json");
            var datas = JsonSerializer.Deserialize<List<Userr>>(txt).ToList();
            return datas;

        }
       
        return null;
    }

    private void save_Click(object sender, EventArgs e)
    {
        Userr u1 = new Userr();
        u1.Birthdate = dt.Text;
        u1.SurName = sname.Text;
        u1.Number = number.Text;

        if (male.Checked)
        {
            u1.Gender = male.Text;
        }
        else if (female.Checked)
        {
            u1.Gender = female.Text;

        }
        u1.City = city.Text; u1.Country = country.Text;
        u1.Name = name.Text;
        u1.FatherName = fname.Text;
        var t = JSonread();
        if (t is not null)
        {

            label9.Text = "Bu user movcuddur load edin";
        }
        else
        {
            userrs.Add(u1);
            Jsonwrite();
        }
        userrs = new List<Userr>();
        city.Text = "";
        country.Text = "";
        name.Text = "";
        fname.Text = "";
        dt.Text = "";
        number.Text = "";
        sname.Text = "";

    }

    private void load_Click(object sender, EventArgs e)
    {
        label9.Text = "";
        var t = JSonread();
        city.Text = t.ElementAt(0).City; 
        country.Text = t.ElementAt(0).Country;
        name.Text = t.ElementAt(0).Name;
        fname.Text = t.ElementAt(0).FatherName;
        dt.Text = t.ElementAt(0).Birthdate;
        number.Text = t.ElementAt(0).Number;    
       sname.Text = t.ElementAt(0).SurName;    
    }
}
