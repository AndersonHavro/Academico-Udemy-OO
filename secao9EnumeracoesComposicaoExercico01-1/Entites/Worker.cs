﻿
using secao9EnumeracoesComposicaoExercico01_1.Entites.Enums;
using System.Collections.Generic;

namespace secao9EnumeracoesComposicaoExercico01_1.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel MyProperty { get; set; }
        public double BaseSalary { get; set; }
        public Depertament Depertament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel myProperty, double baseSalary, Depertament depertament)
        {
            Name = name;
            MyProperty = myProperty;
            BaseSalary = baseSalary;
            Depertament = depertament;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;       
        }
    }
}
