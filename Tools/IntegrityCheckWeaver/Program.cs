using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace IntegrityCheckWeaver
{
    static class Program
    {
        /// <summary>
        /// Why, you may ask?
        /// Because certain individuals with incredibly loose morals are hell-bent on making the game worse for everyone
        /// </summary>
        static int Main(string[] args)
        {
            if (args.Length <= 0 || !File.Exists(args[0]))
            {
                Console.Error.WriteLine("Bad arguments");
                return 1;
            }

            using var assembly = AssemblyDefinition.ReadAssembly(new FileStream(args[0], FileMode.Open, FileAccess.ReadWrite));
            var modType = assembly.MainModule.Types.SingleOrDefault(it => it.BaseType?.Name == "MelonMod");

            if (modType == null)
            {
                Console.Error.WriteLine("Required types not found");
                return 1;
            }

            assembly.Write();

            return 0;
        }
    }
}