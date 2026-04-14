using System;
using System.Collections.Generic;
using System.Linq;

public class UtilitiesManager
{
	private List<ServiceRequest> requests = new List<ServiceRequest>();
    private List<ServiceRequest> resolvedRequests = new List<ServiceRequest>();


    
    public void AddRequest(ServiceRequest request)
	{

		request.UrgencyLevel = CalculateUrgency(request);
        requests.Add(request);


    }

    private double CalculateUrgency(ServiceRequest request)
    {
        return (request.Priority * 2) + request.Severity - (request.EstimatedHours * 0.1);
    }

    public void DisplayQueue()
    {
        Console.WriteLine("\n--- Pending Requests (Sorted by Urgency) ---");

        requests = requests.OrderByDescending(r => r.UrgencyLevel).ToList();

        for (int i = 0; i < requests.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sorted[i].RequestType} | Urgency: {sorted[i].UrgencyLevel:F2}");
        }
    }

    public ServiceRequest? ProcessRequest(int index)
    {
        var sorted = requests.OrderByDescending(r => r.UrgencyLevel).ToList();

        if (index < 0 || index >= request.Count)
            return null;

        requests = requests.OrderByDescending(requests => requests.urgencyLevel).ToList();

        var request = request[index];
        requests.Remove(request);
        resolvedRequests.Add(request);

        return request;
    }

    public void GenerateReport(ServiceRequest request)
    {
        Console.WriteLine("\n--- Service Report ---");
        Console.WriteLine("Resident Details:");
        Console.WriteLine(request.Resident);

        Console.WriteLine("\nRequest Details:");
        Console.WriteLine($"Type: {request.RequestType}");
        Console.WriteLine($"Priority: {request.Priority}");
        Console.WriteLine($"Severity: {request.Severity}");
        Console.WriteLine($"Estimated Hours: {request.EstimatedHours}");
        Console.WriteLine($"Urgency Level: {request.UrgencyLevel:F2}");
    }

    public void DisplaySummary()
    {
        Console.WriteLine("\n--- Summary ---");

        foreach (var r in resolvedRequests)
        {
            Console.WriteLine($"""
                {r.RequestType} 
                {r.Resident.Name}  
                Urgency: {r.UrgencyLevel:F2}
                """);
        }

        var highest = resolvedRequests.OrderByDescending(r => r.UrgencyLevel).FirstOrDefault();

        if (highest != null)
        {
            Console.WriteLine("\n Highest Urgency Request:");
            Console.WriteLine($"{highest.RequestType} for {highest.Resident.Name} (Score: {highest.UrgencyLevel:F2})");
        }
    }

    public int PendingCount()
    {
        return requests.Count;
    }
}
