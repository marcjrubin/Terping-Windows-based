using System;
using InterpreterBookingSystem.Domain.BusinessClients;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace InterpreterBookingSystem.Services.BusinessClientSvc
{
    /// <summary>
    /// 
    /// </summary>
    public class BusinessClientImpl : IBusinessClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bc"></param>
        public void StoreBusinessClient(BusinessClient bc)
        {
            FileStream fileStream = new FileStream("BusinessClient.bin", FileMode.Create, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fileStream, bc);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bc"></param>
        /// <returns></returns>
        public BusinessClient GetBusinessClient(BusinessClient bc)
        {
            FileStream fileStream = new FileStream("BusinessClient.bin", FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();

            try
            {
                bc = formatter.Deserialize(fileStream) as BusinessClient;
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

            return bc;
        }
    }}
