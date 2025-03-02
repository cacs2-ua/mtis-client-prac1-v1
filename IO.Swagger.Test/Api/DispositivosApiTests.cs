/* 
 * API de Salas, Niveles, Dispositivos y Notificaciones
 *
 * Esta API permite gestionar las entidades:   - Salas: crear, borrar, modificar y consultar.   - Niveles: crear, borrar, modificar y consultar.   - Dispositivos: crear, borrar, modificar y consultar.   - Notificaciones: enviar notificaciones por email mediante los métodos:       • NotificarPresenciaSala       • NotificarUsuarioValido       • NotificarError 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DispositivosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DispositivosApiTests
    {
        private DispositivosApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DispositivosApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DispositivosApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DispositivosApi
            //Assert.IsInstanceOfType(typeof(DispositivosApi), instance, "instance is a DispositivosApi");
        }

        /// <summary>
        /// Test BorrarDispositivo
        /// </summary>
        [Test]
        public void BorrarDispositivoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? codigo = null;
            //string wSKey = null;
            //var response = instance.BorrarDispositivo(codigo, wSKey);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        /// <summary>
        /// Test ConsultarDispositivo
        /// </summary>
        [Test]
        public void ConsultarDispositivoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? codigo = null;
            //string wSKey = null;
            //var response = instance.ConsultarDispositivo(codigo, wSKey);
            //Assert.IsInstanceOf<Dispositivo> (response, "response is Dispositivo");
        }
        /// <summary>
        /// Test ModificarDispositivo
        /// </summary>
        [Test]
        public void ModificarDispositivoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dispositivo body = null;
            //string wSKey = null;
            //var response = instance.ModificarDispositivo(body, wSKey);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        /// <summary>
        /// Test NuevoDispositivo
        /// </summary>
        [Test]
        public void NuevoDispositivoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dispositivo body = null;
            //string wSKey = null;
            //var response = instance.NuevoDispositivo(body, wSKey);
            //Assert.IsInstanceOf<Dispositivo> (response, "response is Dispositivo");
        }
    }

}
