using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedCSharpTest;

[UClass]
public class CSharpTest : Actor
{
  protected CSharpTest(IntPtr nativeObject) : base(nativeObject)
  {
  }

  protected override void ReceiveBeginPlay()
  {
    PrintString("Hello from C#");
    base.ReceiveBeginPlay();
  }

  [UProperty(PropertyFlags.BlueprintReadOnly)]
  public int MyInt { get; set; }

  [UProperty(PropertyFlags.BlueprintReadOnly)]
  public float MyFloat { get; set; }

  [UProperty(PropertyFlags.BlueprintReadWrite)]
  public string MyString { get; set; }

  [UProperty(DefaultComponent = true, RootComponent = true)]
  public StaticMeshComponent MyRootMesh {  get; set; }

  [UProperty(DefaultComponent = true)]
  public StaticMeshComponent MyOtherMesh { get; set; }

  [UProperty(DefaultComponent = true, AttachmentComponent = nameof(MyRootMesh))]
  public StaticMeshComponent MyMeshAttachedToRoot { get; set; }

  [UFunction(FunctionFlags.BlueprintCallable)]
  public void MyFunction(bool myBool, int MyInt)
  {
    PrintString("Hello from MyFunction!");
  }
}
