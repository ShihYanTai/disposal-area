# Define two dates.
$Date2 = Get-Date -Date '2010/8/18' -Hour 13 -Minute 30 -Second 30
$Date1 = Get-Date -Date '2010/1/1'  -Hour 8  -Minute 0  -Second 15

# Calculate the interval between the two dates.
$Interval = $Date2 - $Date1
"{0} - {1} = {2}" -f $Date2, $Date1, ($Interval.ToString())

#  Display individual properties of the resulting TimeSpan object.
"   {0,-35} {1,20}"    -f "Value of Days Component:", $Interval.Days
"   {0,-35} {1,20}"    -f "Total Number of Days:", $Interval.TotalDays
"   {0,-35} {1,20}"    -f "Value of Hours Component:", $Interval.Hours
"   {0,-35} {1,20}"    -f "Total Number of Hours:", $Interval.TotalHours
"   {0,-35} {1,20}"    -f "Value of Minutes Component:", $Interval.Minutes
"   {0,-35} {1,20}"    -f "Total Number of Minutes:", $Interval.TotalMinutes
"   {0,-35} {1,20:N0}" -f "Value of Seconds Component:", $Interval.Seconds
"   {0,-35} {1,20:N0}" -f "Total Number of Seconds:", $Interval.TotalSeconds
"   {0,-35} {1,20:N0}" -f "Value of Milliseconds Component:", $Interval.Milliseconds
"   {0,-35} {1,20:N0}" -f "Total Number of Milliseconds:", $Interval.TotalMilliseconds
"   {0,-35} {1,20:N0}" -f "Ticks:", $Interval.Ticks