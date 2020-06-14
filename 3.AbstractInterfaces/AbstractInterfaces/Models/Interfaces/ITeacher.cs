using System;
using System.Collections.Generic;

namespace AbstractInterfaces.Models.Interfaces
{
    public interface ITeacher
    {
        List<string> Subjects { get; set; }

        void PrintUser(List<string> subject);
    }
}
