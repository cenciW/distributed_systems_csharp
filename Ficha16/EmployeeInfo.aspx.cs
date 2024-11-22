using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EmployeeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) InitPositionRole();

    }



    protected void WorkerChecked(object sender, EventArgs e)
    {
        InitPositionRole();

    }

    protected void BossChecked(object sender, EventArgs e)
    {
        PositionRole.Items.Clear();
        PositionRole.Enabled = true;
        PositionRole.Items.Add("General Manager");
        PositionRole.Items.Add("Project Manager");

    }

    protected void VPChecked(object sender, EventArgs e)
    {
        PositionRole.Items.Clear();
        PositionRole.Enabled = true;
        PositionRole.Items.Add("VP Sales");
        PositionRole.Items.Add("VP Marketing");
        PositionRole.Items.Add("VP Production");
        PositionRole.Items.Add("VP Human Resources");

    }

    protected void PresidentChecked(object sender, EventArgs e)
    {
        PositionRole.Items.Clear();
        PositionRole.Enabled = false;
        //PositionRole.Items.Add("President");
    }




    protected void InitPositionRole()
    {
        PositionRole.Items.Clear();
        PositionRole.Enabled = true;
        PositionRole.Items.Add("Analyst");
        PositionRole.Items.Add("Designer");
        PositionRole.Items.Add("Developer");
    }
}