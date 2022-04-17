using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SomeSortOfSerializer
{
    public class SSOS<T>
    {
        public void Serialize(T serializableObject)
        {
            FileStream fileStream = new FileStream("hls.dat", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                binaryFormatter.Serialize(fileStream, serializableObject);
            }
            catch (SerializationException ex)
            {
                //failed to serialize
            }
            finally
            {
                fileStream.Close();
            }
        }

        public T Deserialize()
        {
            T serializableObject = default;
            FileStream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                fileStream = new FileStream("hls.dat", FileMode.Open);
                serializableObject = (T)binaryFormatter.Deserialize(fileStream);
            }
            catch (FileNotFoundException ex)
            {
                //file open
            }
            catch (SerializationException ex)
            {
                //deserialization failed
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return serializableObject;
        }
    }
}