namespace AttributesApp.Attributes
{
    internal class Error
    {
        private readonly string _field;
        private readonly string _message;

        public Error(string field, string message)
        {
            _field = field;
            _message = message;
        }

        public override string ToString()
        {
            return $"\"{_field}\": \"{_message}\"";
        }
    }
}
