namespace CPProject.DataBaseModel.interfaces
{
    public interface IJSONAutoSerializable
    {
        public bool SerialiazeToJSON(string inFileName);
        public bool DeserializationFromJSON(string fromFileName);
    }
}
