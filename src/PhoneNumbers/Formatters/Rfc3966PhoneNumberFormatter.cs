namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the RFC3966 format.
/// </summary>
internal sealed class Rfc3966PhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="Rfc3966PhoneNumberFormatter"/> class.
    /// </summary>
    private Rfc3966PhoneNumberFormatter()
    {
    }

    /// <summary>
    /// Gets the <see cref="Rfc3966PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new Rfc3966PhoneNumberFormatter();

    /// <inheritdoc/>
    public override bool CanFormat(string format) =>
        format?.Equals("RFC3966", StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    public override string Format(PhoneNumber phoneNumber)
    {
        if (phoneNumber is null)
        {
            throw new ArgumentNullException(nameof(phoneNumber));
        }

        if (phoneNumber.NationalDestinationCode is not null)
        {
            return $"tel:{phoneNumber.Country.CallingCode}-{phoneNumber.NationalDestinationCode}-{phoneNumber.SubscriberNumber}";
        }

        return $"tel:{phoneNumber.Country.CallingCode}-{phoneNumber.SubscriberNumber}";

    }
}
