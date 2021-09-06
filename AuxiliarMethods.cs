using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AED_AP2
{
    static class AuxiliarMethods
    {
        public static void FillDataSource(DataGridView gvStudentProjects, Projects[] dataProject,int position,string message)
        {
            try
            {
                gvStudentProjects.Rows.Clear();
                for (int i = 0; i < dataProject.Length; i++)
                {
                    gvStudentProjects.Rows.Add();
                    gvStudentProjects.Rows[i].Cells[0].Value = dataProject[i].idStudent;
                    gvStudentProjects.Rows[i].Cells[1].Value = dataProject[i].names;
                    gvStudentProjects.Rows[i].Cells[2].Value = dataProject[i].lastNames;
                    gvStudentProjects.Rows[i].Cells[3].Value = dataProject[i].daySent;
                    gvStudentProjects.Rows[i].Cells[4].Value = dataProject[i].dayLimit;
                    if (dataProject[i].lateSent == true)
                        gvStudentProjects.Rows[i].Cells[5].Value = "Retrasada";
                    else
                        gvStudentProjects.Rows[i].Cells[5].Value = "A tiempo";
                    gvStudentProjects.Rows[i].Cells[6].Value = dataProject[i].projectName;
                    gvStudentProjects.Rows[i].Cells[7].Value = dataProject[i].grade;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
            }
        }
        public static void sentLateDataSource(DataGridView gvStudentProjects, Projects[] dataProject)
        {
           gvStudentProjects.Rows.Clear();
           for (int i = 0; i < dataProject.Length; i++)
           {
              if(dataProject[i].lateSent == true)
              {
                  gvStudentProjects.Rows.Add();
                  gvStudentProjects.Rows[i].Cells[0].Value = dataProject[i].idStudent;
                  gvStudentProjects.Rows[i].Cells[1].Value = dataProject[i].names;
                  gvStudentProjects.Rows[i].Cells[2].Value = dataProject[i].lastNames;
                  gvStudentProjects.Rows[i].Cells[3].Value = dataProject[i].daySent;
                  gvStudentProjects.Rows[i].Cells[4].Value = dataProject[i].dayLimit;
                  gvStudentProjects.Rows[i].Cells[5].Value = "Retrasada";
                  gvStudentProjects.Rows[i].Cells[6].Value = dataProject[i].projectName;
                  gvStudentProjects.Rows[i].Cells[7].Value = dataProject[i].grade;
                 
              } 
           }
        }
    }
    
}
