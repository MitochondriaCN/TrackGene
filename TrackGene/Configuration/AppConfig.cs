namespace TrackGene.Configuration
{
    public class AppConfig
    {
        public ConfigurationItemValue TrackPath { get; set; } = new(null);
    }

    public class ConfigurationItemValue
    {
        public ConfigurationItemValue(string? value)
        {
            Value = value;
        }

        private string? value;
        public string? Value
        {
            set => this.value = string.IsNullOrEmpty(value) ? null : value;
            get => value;
        }

        public string GetDisplayValue() => value ?? "(null)";
    }
}