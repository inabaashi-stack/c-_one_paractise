Show / Submit Button Code
C#
private void btnshow_Click(object sender, EventArgs e)
{
1. // Creating variables
    string name, department, showdata;

    // Getting values from textboxes
    name = txtname.Text;
    int id = int.Parse(txtstudent.Text); // Corrected to read ID from txtstudent
    department = txtdepartment.Text;
    int semester = int.Parse(txtsemester.Text);

    // Format and display the data
    showdata = "Name: " + name + " | ID: " + id + " | Department: " + department + " | Semester: " + semester;
    lbloutput.Text = showdata;
}
2. Clear Button Code
C#
private void btnclear_Click(object sender, EventArgs e)
{
    txtname.Text = "";
    txtstudent.Text = "";
    txtdepartment.Text = "";
    txtsemester.Text = "";
    lbloutput.Text = "";
}
3. Exit Button Code
C#
private void btnexit_Click(object sender, EventArgs e)
{
    Application.Exit();
}