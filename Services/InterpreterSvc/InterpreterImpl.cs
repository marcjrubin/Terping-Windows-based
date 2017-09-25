using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterpreterBookingSystem.Domain.Interpreters;

namespace InterpreterBookingSystem.Services.InterpreterSvc
{
    public class InterpreterImpl : IInterpreter
    {
        public void StoreInterpreter(Interpreter terp)
        { 
            FileStream fileStream = new FileStream("Interpreter.bin", FileMode.Create, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fileStream, terp);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Complete the entry and resubmit.", e);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid data. Enter correct information.", e);
            }
            catch (IOException e)
            {
                throw new IOException("Unable to create a file. Try again.", e);
            }
            catch (SerializationException e)
            {
                throw new SerializationException("Unable to save. Try again.", e);
            }
            finally
            {
                fileStream.Close();
            }
        }

        public Interpreter GetInterpreter(Interpreter terp)
        {
            FileStream fileStream = new FileStream("Interpreter.bin", FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                terp = formatter.Deserialize(fileStream) as Interpreter;
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Empty File", e);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Conflict Data Information", e);
            }
            catch (IOException e)
            {
                throw new IOException("Cannot read file, may be corrupted.", e);
            }
            catch (SerializationException e)
            {
                throw new SerializationException("Unable to open file. Try again.", e);
            }
            finally
            {
                fileStream.Close();
            }

            return terp;
        }
    }
}
