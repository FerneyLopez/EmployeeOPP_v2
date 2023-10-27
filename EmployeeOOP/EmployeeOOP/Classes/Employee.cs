using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    //clase abstracta
    public abstract class Employee
    {
        #region Properties
        //Para crear las propiedades coloco prop y doble tab
        public int Id { get; set; }

        public string? FirstName { get; set; } //notación elvis propiedad no nuleable debe tener un valor por eso se agrega ? porque puede ser nulo

        public string? LastName { get; set; }

        public Date? BirthDate { get; set; }

        public Date? HiringDate { get; set; } // .net tiene la clase datetime

        public bool? IsActive { get; set; }
        #endregion

        #region Methods
        // como es una clase abstracta debe tener al menos un método abstracto.
        //el método define el salario a pagar por cada una de las clases que van heredar de la clase abstracta
        //es un método abstracto porque hay diferentes formas de pago para cada empleado, salario, por hora, por comisión.
        public abstract decimal GetValueToPay();

        //se sobreescribe el método ToString de la clase String para ver por consola.
        public override string ToString()
        {
            return $"INFORMACIÓN EMPLEADO \n\t " +
                    $"ID: {Id}\n\t" +
                    $"Nombres: {FirstName}\n\t" +
                    $"Apellidos: {LastName}\n\t" +
                    $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                    $"Fecha de Contratación: {HiringDate}\n\t" +
                    $"¿Empleado Activo?: {HiringDate}\n\t";
        }
        #endregion
    }
}
