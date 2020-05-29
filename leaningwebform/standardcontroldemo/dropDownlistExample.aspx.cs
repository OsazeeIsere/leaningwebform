using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace leaningwebform.standardcontroldemo
{
    public partial class dropDownlistExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EmployeeNameAdd();
                Addcontry();
                loadAlphabet();
            }
        }

        private void loadAlphabet()
        {
            //Ascii of A-Z is 65-90
            //Ascii of a-z is 97-122
            //Ascii of 0-9 is 48-57
            ListItem li = null;
            for (int i=65;i<=90;i++)
            {
                li = new ListItem(((char)i).ToString(), ((char)i).ToString());
                DropDownList4.Items.Add(li);
                ListBox1.Items.Add(li);
                li = new ListItem(((char)(i+32)).ToString(), ((char)(i+32)).ToString());
                DropDownList5.Items.Add(li);
               
                if (i - 17 <= 57)
                {
                    li = new ListItem(((char)(i - 17)).ToString(), ((char)(i - 17)).ToString());
                    DropDownList6.Items.Add(li);
                }
               
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //before this works set the postback property of the control to true i.e the page is being submitted to itself
            TextBox1.Text = DropDownList1.SelectedItem.Text;
        }
        private void EmployeeNameAdd()
        {
            ListItem lit1 = new ListItem("Jason","Jason");
            ListItem lit2 = new ListItem("JOAN", "JOAN");
            ListItem lit3 = new ListItem("JIM", "JIM");
            DropDownList2 .Items.Add(lit1);
            DropDownList2.Items.Add(lit2);
            DropDownList2.Items.Add(lit3);


        }
        private void Addcontry()
        {
          ArrayList myarray = new ArrayList();
            myarray.Add("Nigeria");
            myarray.Add("USA");
            myarray.Add("UK");
            DropDownList3.DataSource =myarray ;
            DropDownList3.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList4.Items.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = TextBox4.Text;
            //DropDownList4.Items.Remove(str);
          //  TextBox5.Text = DropDownList4.Items.Count.ToString ();

            ListItem li = DropDownList4.Items.FindByText(str);
            if (li !=null)
            {
                int index = DropDownList4.Items.IndexOf(li);
                DropDownList4.Items.RemoveAt(index);
                TextBox5.Text = DropDownList4.Items.Count.ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string str = TextBox4.Text;
            ListItem li = new ListItem(str);
           DropDownList4.Items.Insert  (2,str);
            TextBox5.Text = DropDownList4.Items.Count.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string str = TextBox4.Text;
            ListItem li = DropDownList4.Items.FindByText(str);
            if (li != null)
            {
                int index = DropDownList4.Items.IndexOf(li);
                DropDownList4.SelectedIndex =index ;
               
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string str = TextBox4.Text;
            ListItem li = DropDownList4.Items.FindByText(str);
            if (li != null)
            {
                int index = DropDownList4.Items.IndexOf(li);
                DropDownList4.SelectedIndex = index;

            }
        }
    }
    }

