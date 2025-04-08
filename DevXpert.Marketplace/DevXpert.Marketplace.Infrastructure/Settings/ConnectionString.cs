using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Infrastructure;

public class ConnectionString
{
    public const string SettingsKey = "MarketplaceDatabase";

    public ConnectionString(string value)
        => Value = value;

    public string Value { get; }

    public static implicit operator string(ConnectionString connectionString)
        => connectionString.Value;
}
