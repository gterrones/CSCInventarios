using CSCInventarios.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSCInventarios.EL;
using System.Collections.Generic;

namespace CSCnvetarios.TestProject
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para SolicitudDALTest y se pretende que
    ///contenga todas las pruebas unitarias SolicitudDALTest.
    ///</summary>
    [TestClass()]
    public class SolicitudDALTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        /// <summary>
        ///Una prueba de CrearSolicitud
        ///</summary>
        [TestMethod()]
        public void CrearSolicitudTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            Solicitud solicitud = null; // TODO: Inicializar en un valor adecuado
            target.CrearSolicitud(solicitud);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de EliminarSolicitud
        ///</summary>
        [TestMethod()]
        public void EliminarSolicitudTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            int sl_id = 0; // TODO: Inicializar en un valor adecuado
            target.EliminarSolicitud(sl_id);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de LeerEstacionesPorEstacionId
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CSCInventarios.DAL.dll")]
        public void LeerEstacionesPorEstacionIdTest()
        {
            SolicitudDAL_Accessor target = new SolicitudDAL_Accessor(); // TODO: Inicializar en un valor adecuado
            int estacion_id = 0; // TODO: Inicializar en un valor adecuado
            Estacion expected = null; // TODO: Inicializar en un valor adecuado
            Estacion actual;
            actual = target.LeerEstacionesPorEstacionId(estacion_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudEntreFechas
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudEntreFechasTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            DateTime fechaInicio = new DateTime(); // TODO: Inicializar en un valor adecuado
            DateTime fechaFin = new DateTime(); // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudEntreFechas(fechaInicio, fechaFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudPorEstacionId
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudPorEstacionIdTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            int estacion_id = 0; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudPorEstacionId(estacion_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudPorSlId
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudPorSlIdTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            int sl_id = 0; // TODO: Inicializar en un valor adecuado
            Solicitud expected = null; // TODO: Inicializar en un valor adecuado
            Solicitud actual;
            actual = target.LeerSolicitudPorSlId(sl_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudPorUsuarioId
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudPorUsuarioIdTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            int usuario_id = 0; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudPorUsuarioId(usuario_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudesAceptadas
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudesAceptadasTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            bool sl_aceptacion = false; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudesAceptadas(sl_aceptacion);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudesAsignadas
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudesAsignadasTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            bool sl_asignacion = false; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudesAsignadas(sl_asignacion);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudesAtendidas
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudesAtendidasTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            bool sl_atencion = false; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudesAtendidas(sl_atencion);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerSolicitudesRecepcionadas
        ///</summary>
        [TestMethod()]
        public void LeerSolicitudesRecepcionadasTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            bool sl_recepcion = false; // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerSolicitudesRecepcionadas(sl_recepcion);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de LeerTodasLasSolicitudes
        ///</summary>
        [TestMethod()]
        public void LeerTodasLasSolicitudesTest()
        {
            SolicitudDAL target = new SolicitudDAL(); // TODO: Inicializar en un valor adecuado
            List<Solicitud> expected = null; // TODO: Inicializar en un valor adecuado
            List<Solicitud> actual;
            actual = target.LeerTodasLasSolicitudes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
