using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilleSW
{
    class Class1
    {
        public Class1()
        {

        }

        public void Foo()
        {
            double x = WeightConverter.Instance.KgToPound(3);
            double y = WeightConverter.Instance.PoundToKg(5);

            Singleton.Instance.FooBar();

            var a = "10";
            var b = 0.11;

            var c = a + b;
        }


    }

    public sealed class WeightConverter
    {

        private static readonly Lazy<WeightConverter> _instance = new Lazy<WeightConverter>(() => new WeightConverter());
        public static WeightConverter Instance { get { return _instance.Value; } }

        private const double poundConst = 2.205;

        private WeightConverter()
        {

        }

        public double KgToPound(double kg)
        {
            return kg * poundConst;
        }

        public double PoundToKg(double pound)
        {
            return pound / poundConst;
        }
    }

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public void FooBar()
        {

        }
    }
}
