using System;
using CastleWindsor;
using Castle.MicroKernel.Registration;
using Castle.Windsor;


namespace CastleWindsor
{
    partial class Program
    {


        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<CastleWindsor.Persona>());
            container.Register(Castle.MicroKernel.Registration.Component.For<CastleWindsor.INombre>().ImplementedBy<CastleWindsor.Nombre>());
            container.Register(Castle.MicroKernel.Registration.Component.For<CastleWindsor.IApellido>().ImplementedBy<CastleWindsor.Apellido>());

            var persona = container.Resolve<CastleWindsor.Persona>();
            persona.NombreCompleto();

            Console.WriteLine("Hola! {0}", persona.NombreCompleto());

        }
    }
}