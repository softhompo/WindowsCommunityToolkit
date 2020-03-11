//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Microsoft.Toolkit.Uwp.Input.GazeInteraction { /*

/// <summary>
/// This struct encapsulates the location and timestamp associated with the user's gaze 
/// and is used as an input and output parameter for the IGazeFilter.Update method
/// </summary>
private ref struct GazeFilterArgs sealed
{
    /// <summary>
    /// The current point in the gaze stream
    /// </summary>
    property Point Location {Point get() { return _location; }}

    /// <summary>
    /// The timestamp associated with the current point
    /// </summary>
    property TimeSpan Timestamp {TimeSpan get() { return _timestamp; }}

internal:

    GazeFilterArgs(Point location, TimeSpan timestamp)
    {
        _location = location;
        _timestamp = timestamp;
    }

private:

    Point _location;
    TimeSpan _timestamp;
};

// Every filter must provide an Wpdate method which transforms sample data 
// and returns filtered output
private interface class IGazeFilter
{
    GazeFilterArgs Update(GazeFilterArgs args);
    void LoadSettings(ValueSet settings);
};


// Basic filter which performs no input filtering -- easy to
// use as a default filter.
internal class NullFilter sealed : IGazeFilter
{
public:
    virtual inline GazeFilterArgs Update(GazeFilterArgs args)
    {
        return args;
    }

    virtual inline void LoadSettings(ValueSet settings)
    {

    }
};

*/ }
