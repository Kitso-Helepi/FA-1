using System;

public class ServiceRequest
{
	public Resident Resident { get; set; }
	public string RequestType { get; set; }
	public int Priority { get; set; }
	public int Severity { get; set; }
	public double EstimatedHours { get; set; }
	public double UrgencyLevel { get; set; }


    public ServiceRequest(Resident resident, string requestType, int priority, int severity, double estimatedHours, double urgencyLevel)
	{
		Resident = resident;
		RequestType = requestType;
		Priority = priority;
		Severity = severity;
		EstimatedHours = estimatedHours;
		UrgencyLevel = urgencyLevel;
		
	}
}
