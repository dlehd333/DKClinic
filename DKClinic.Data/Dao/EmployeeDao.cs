﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DKClinic.Data
{
    public class EmployeeDao : SingleKeyDao<Employee, int>
    {
        protected override Expression<Func<Employee, int>> KeySelector => x => x.EmployeeID;

        protected override Expression<Func<Employee, bool>> IsKey(int key)
        {
            return x => x.EmployeeID == key;
        }

        public Employee GetByName(string name)
        {
            using (var context = DKClinicEntities.Create())
            {
                return context.Employees.Where(x => x.Name == name)
                                        .FirstOrDefault();
            }
        }

        public Employee GetWithDepartmentAndPositionNameByName(string name)
        {
            using (var context = DKClinicEntities.Create())
            {
                var query = from x in context.Employees.Where(x => x.Name == name)
                            select new { Employee = x, DepartmentName = x.Department.Name, PositionName = x.Position.Name };
                var item = query.ToList().FirstOrDefault();

                if (item == null) return null;
                
                item.Employee.DepartmentName = item.DepartmentName;
                item.Employee.PositionName = item.PositionName;

                return item.Employee;
            }
        }

        public List<Employee> GetWithDepartmentAndPositionName()
        {
            using (var context = DKClinicEntities.Create())
            {
                var query = from x in context.Employees
                            select new { Employee = x, DepartmentName = x.Department.Name, PositionName = x.Position.Name };
                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Employee.DepartmentName = item.DepartmentName;
                    item.Employee.PositionName = item.PositionName;
                }

                return list.ConvertAll(x => x.Employee);
            }
        }
    }
}
