using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using Excepciones;
using EntidadesAbstractas;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
 
        [TestMethod]
        public void ValidarNacionalidadInvalidaException()
        {
            Alumno alumno;

            try
            {
                alumno = new Alumno(1, "Jonatan", "Gimenez", "36324773", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(NacionalidadInvalidaException));
            }
        }

        [TestMethod]
        public void ValidarSinProfesorException()
        {
            Universidad universidad = new Universidad();

            try
            {
                universidad += Universidad.EClases.Laboratorio;
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(SinProfesorException));
            }
        }

        [TestMethod]
        public void ValidarAlumnoRepetidoException()
        {
            Universidad universidad = new Universidad();
            Alumno alumno = new Alumno(1, "Jonatan", "Gimenez", "36324773", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(1, "Jonatan", "Gimenez", "36324773", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            universidad += alumno2;

            try
            {
                universidad += alumno2;
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(AlumnoRepetidoException));
            }
        }

 
        [TestMethod]
        public void ValidarCantidadDeAlumnos()
        {
            Alumno alumno = new Alumno(1, "Jony", "Gimenez", "36324773", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(2, "Jonatan", "Gutierrez", "36324774", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno alumno3 = new Alumno(4, "John", "Gomez", "36324775", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.AlDia);
            Alumno alumno4 = new Alumno(5, "Jonathan", "Güemez", "36324776", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);
            Universidad universidad = new Universidad();

            universidad += alumno;
            universidad += alumno2;
            universidad += alumno3;
            universidad += alumno4;

            Assert.AreEqual(universidad.Alumnos.Count, 4);
        }

    
        [TestMethod]
        public void ValidarAtributosNulos()
        {
            Alumno alumno = new Alumno(1, "Jonatan", "Gimenez", "36324773", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.IsNotNull(alumno.DNI);
            Assert.IsNotNull(alumno.Apellido);
            Assert.IsNotNull(alumno.Nombre);
            Assert.IsNotNull(alumno.Nacionalidad);
        }
    }
}

