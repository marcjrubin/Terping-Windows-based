using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterpreterBookingSystem.Domain.Interpreters;

namespace InterpreterBookingSystemTest
{
    /// <summary>
    /// Unit testing Interpreter Class for validation
    /// </summary>
    class InterpreterTest
    {
        [Test]
        public void ValidateInterpreterTest()
        {
            Interpreter interpreter = new Interpreter();

            interpreter.Name = "Monica Romney";
            interpreter.Address1 = "100 West Ave";
            interpreter.Address2 = "Apt. 110";
            interpreter.City = "Louisville";
            interpreter.State = "KY";
            interpreter.Zip = "47384";
            interpreter.Phone = "502-234-5564";
            interpreter.Email = "monica@interpreter.com";
            interpreter.YearsOfExperience = 10;
            interpreter.HighestLevelCertification = "RID III";

            bool validate = interpreter.ValidateInterpreter();

            Assert.IsTrue(validate, "Interpreter Validation Test Failed");            
            Assert.GreaterOrEqual(interpreter.YearsOfExperience, 0, "YearsOfExperience GreaterOrEqual Test Failed");
        }
    }
}
