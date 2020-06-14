using System;
using System.Collections.Generic;

namespace AbstractInterfaces.Models.Interfaces
{
    public interface IStudent
    {
        List<int> Grades { get; set; }

        void PrintUser(List<int> grades);
    }
}
