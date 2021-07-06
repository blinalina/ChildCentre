using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildCentre
{
    public class ScheduleModel
    {
        public int ID { get; }
        public int ID_cours { get; }
        public string Cours_name { get; }
        public int ID_teacher { get; }
        public string Name_teacher { get; }
        public string Day_of_the_week { get; }
        public DateTime Start_time { get; }
        public DateTime End_time { get; }
        public string St_time { get; }
        public string En_time { get; }
        public string Class_room { get; }

        public ScheduleModel(int id, int id_cours, string cours_name, int id_teacher, string day_of_the_week, DateTime start_time, DateTime end_time, string class_room)
        {
            ID = id;
            ID_cours = id_cours;
            ID_teacher = id_teacher;
            Cours_name = cours_name;
            Day_of_the_week = day_of_the_week;
            Start_time = start_time;
            End_time = end_time;
            Class_room = class_room;
        }
        public ScheduleModel(int id, int id_cours, string cours_name, string name_teacher, string day_of_the_week, string st_time, string en_time, string class_room)
        {
            ID = id;
            ID_cours = id_cours;
            Name_teacher = name_teacher;
            Cours_name = cours_name;
            Day_of_the_week = day_of_the_week;
            St_time = st_time;
            En_time = en_time;
            Class_room = class_room;
        }
    }
}
