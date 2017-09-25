using System;
using InterpreterBookingSystem.Domain.Assignment;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace InterpreterBookingSystem.Services.AssignmentSvc
{
    public class AssignmentImpl : IAssignment
    {
        public void StoreAssignment(Assign assign)
        {
            FileStream fileStream = new FileStream("Assignment.bin", FileMode.Create, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fileStream, assign);
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

        public Assign GetAssignment(Assign assign)
        {
            FileStream fileStream = new FileStream("Assignment.bin", FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                assign = formatter.Deserialize(fileStream) as Assign;
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
            
            return assign;
        }
    }
}
