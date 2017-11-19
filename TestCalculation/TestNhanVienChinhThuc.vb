Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Microsoft.Data.Tools.Schema.Sql.UnitTesting
Imports Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class TestNhanVienChinhThuc
    Inherits SqlDatabaseTestClass

    Sub New()
        InitializeComponent()
    End Sub

    <TestInitialize()>
    Public Sub TestInitialize()
        InitializeTest()
    End Sub

    <TestCleanup()>
    Public Sub TestCleanup()
        CleanupTest()
    End Sub



#Region "Designer support code"

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim dbo_NhanVienChinhThucTest_TestAction As Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestNhanVienChinhThuc))
        Dim RowCountCondition1 As Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition
        Dim ScalarValueCondition1 As Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition
        Me.dbo_NhanVienChinhThucTestData = New Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions()
        dbo_NhanVienChinhThucTest_TestAction = New Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction()
        RowCountCondition1 = New Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition()
        ScalarValueCondition1 = New Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition()
        '
        'dbo_NhanVienChinhThucTest_TestAction
        '
        dbo_NhanVienChinhThucTest_TestAction.Conditions.Add(RowCountCondition1)
        dbo_NhanVienChinhThucTest_TestAction.Conditions.Add(ScalarValueCondition1)
        resources.ApplyResources(dbo_NhanVienChinhThucTest_TestAction, "dbo_NhanVienChinhThucTest_TestAction")
        '
        'dbo_NhanVienChinhThucTestData
        '
        Me.dbo_NhanVienChinhThucTestData.PosttestAction = Nothing
        Me.dbo_NhanVienChinhThucTestData.PretestAction = Nothing
        Me.dbo_NhanVienChinhThucTestData.TestAction = dbo_NhanVienChinhThucTest_TestAction
        '
        'RowCountCondition1
        '
        RowCountCondition1.Enabled = True
        RowCountCondition1.Name = "RowCountCondition1"
        RowCountCondition1.ResultSet = 1
        RowCountCondition1.RowCount = 3
        '
        'ScalarValueCondition1
        '
        ScalarValueCondition1.ColumnNumber = 2
        ScalarValueCondition1.Enabled = True
        ScalarValueCondition1.ExpectedValue = "MinhTuan  "
        ScalarValueCondition1.Name = "ScalarValueCondition1"
        ScalarValueCondition1.NullExpected = False
        ScalarValueCondition1.ResultSet = 1
        ScalarValueCondition1.RowNumber = 2
    End Sub

#End Region

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
#End Region


    <TestMethod()> _
    Public Sub dbo_NhanVienChinhThucTest()
        Dim testActions As SqlDatabaseTestActions = Me.dbo_NhanVienChinhThucTestData
        'Execute the pre-test script
        '
        System.Diagnostics.Trace.WriteLineIf((Not (testActions.PretestAction) Is Nothing), "Executing pre-test script...")
        Dim pretestResults() As SqlExecutionResult = TestService.Execute(Me.PrivilegedContext, Me.PrivilegedContext, testActions.PretestAction)
        'Execute the test script
        '
        System.Diagnostics.Trace.WriteLineIf((Not (testActions.TestAction) Is Nothing), "Executing test script...")
        Dim testResults() As SqlExecutionResult = TestService.Execute(Me.ExecutionContext, Me.PrivilegedContext, testActions.TestAction)
        'Execute the post-test script
        '
        System.Diagnostics.Trace.WriteLineIf((Not (testActions.PosttestAction) Is Nothing), "Executing post-test script...")
        Dim posttestResults() As SqlExecutionResult = TestService.Execute(Me.PrivilegedContext, Me.PrivilegedContext, testActions.PosttestAction)
    End Sub
    Private dbo_NhanVienChinhThucTestData As SqlDatabaseTestActions
End Class

