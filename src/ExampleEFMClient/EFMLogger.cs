using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

public class MyMessageInspector : IClientMessageInspector {
    public void AfterReceiveReply(ref Message reply, object correlationState) {
        // Log the reply message
        Console.WriteLine($"Received reply: {reply}");
        Console.WriteLine("\n\n");
    }

    public object BeforeSendRequest(ref Message request, IClientChannel channel) {
        // Log the request message
        Console.WriteLine($"Sending request: {request}");
        Console.WriteLine("\n\n");
        return null;
    }
}

public class MyEndpointBehavior : IEndpointBehavior {
    public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime) {
        clientRuntime.ClientMessageInspectors.Add(new MyMessageInspector());
    }

    // Implement other methods of IEndpointBehavior interface with empty bodies
    public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher) { }
    public void Validate(ServiceEndpoint endpoint) { }
}
