Imports Microsoft.VisualBasic
Imports System
Imports System.Threading

Public Class TimerExample

    <MTAThread()> _
    Shared Sub Main()

        ' Create an event to signal the timeout count threshold in the
        ' timer callback.
        Dim autoEvent As New AutoResetEvent(False)

        Dim statusChecker As New StatusChecker(10)

        ' Create an inferred delegate that invokes methods for the timer.
        Dim tcb As TimerCallback = AddressOf statusChecker.CheckStatus

        ' Create a timer that signals the delegate to invoke
        ' CheckStatus after one second, and every 1/4 second
        ' thereafter.
        Console.WriteLine("{0} Creating timer." & vbCrLf, _
            DateTime.Now.ToString("h:mm:ss.fff"))
        Dim stateTimer As Timer = New Timer(tcb, autoEvent, 1000, 250)

        ' When autoEvent signals, change the period to every 
        ' 1/2 second.
        autoEvent.WaitOne(6000, False)
        stateTimer.Change(0, 500)
        Console.WriteLine(vbCrLf & "Changing period." & vbCrLf)

        ' When autoEvent signals the second time, dispose of 
        ' the timer.
        autoEvent.WaitOne(5000, False)
        stateTimer.Dispose()
        Console.WriteLine(vbCrLf & "Destroying timer.")

    End Sub
End Class

Public Class StatusChecker

    Dim invokeCount, maxCount As Integer

    Sub New(ByVal count As Integer)
        invokeCount = 0
        maxCount = count
    End Sub

    ' This method is called by the timer delegate.
    Sub CheckStatus(ByVal stateInfo As Object)
        Dim autoEvent As AutoResetEvent = _
            DirectCast(stateInfo, AutoResetEvent)
        invokeCount += 1
        Console.WriteLine("{0} Checking status {1,2}.", _
            DateTime.Now.ToString("h:mm:ss.fff"), _
            invokeCount.ToString())

        If invokeCount = maxCount Then
            ' Reset the counter and signal to stop the timer.
            invokeCount = 0
            autoEvent.Set()
        End If
    End Sub

End Class
