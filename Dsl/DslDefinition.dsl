<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="900734a0-dc3a-4e8f-891b-3c21a62021a4" Description="Description for YaHZ.modeling_test.modeling_test" Name="modeling_test" DisplayName="modeling_test" Namespace="YaHZ.modeling_test" ProductName="modeling_test" CompanyName="YaHZ" PackageGuid="f5d1e2b1-3a3d-4a7e-862f-40bb45000db9" PackageNamespace="YaHZ.modeling_test" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="3c0271d3-4390-4bbe-8c06-a3902f6ec2a2" Description="Description for YaHZ.modeling_test.ExampleModel" Name="ExampleModel" DisplayName="Example Model" Namespace="YaHZ.modeling_test">
      <Properties>
        <DomainProperty Id="16e1c334-dd3b-45fa-a437-a90eecb8ad04" Description="Description for YaHZ.modeling_test.ExampleModel.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ExampleElement" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ExampleModelHasExampleElements.ExampleElements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="8e18b47d-0fea-40d9-9cf6-c7d83e81bbec" Description="Description for YaHZ.modeling_test.ExampleElement" Name="ExampleElement" DisplayName="Example Element" Namespace="YaHZ.modeling_test">
      <Properties>
        <DomainProperty Id="1dd91a37-eae2-4c27-934a-407ca560762b" Description="Description for YaHZ.modeling_test.ExampleElement.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="802f9986-856f-4d56-9ed1-d427b62576fc" Description="Description for YaHZ.modeling_test.ExampleElement.Description" Name="Description" DisplayName="Description">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="bcb36395-8a68-4535-9d56-690460c3bc37" Description="Description for YaHZ.modeling_test.ExampleElement.Value" Name="Value" DisplayName="Value">
          <Type>
            <ExternalTypeMoniker Name="/System/Int32" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="3e463951-2f37-4d72-9806-f1108f021246" Description="Description for YaHZ.modeling_test.ExampleModelHasExampleElements" Name="ExampleModelHasExampleElements" DisplayName="Example Model Has Example Elements" Namespace="YaHZ.modeling_test" IsEmbedding="true">
      <Source>
        <DomainRole Id="4d4039b6-acc9-40a7-8bb7-cd960676597b" Description="Description for YaHZ.modeling_test.ExampleModelHasExampleElements.ExampleModel" Name="ExampleModel" DisplayName="Example Model" PropertyName="ExampleElements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Example Elements">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="8520ed70-7d09-4e96-adb2-e7b9a450a075" Description="Description for YaHZ.modeling_test.ExampleModelHasExampleElements.ExampleElement" Name="ExampleElement" DisplayName="Example Element" PropertyName="ExampleModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Example Model">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleElement" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <XmlSerializationBehavior Name="modeling_testSerializationBehavior" Namespace="YaHZ.modeling_test">
    <ClassData>
      <XmlClassData TypeName="ExampleModel" MonikerAttributeName="name" SerializeId="true" MonikerElementName="exampleModelMoniker" ElementName="exampleModel" MonikerTypeName="ExampleModelMoniker">
        <DomainClassMoniker Name="ExampleModel" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="ExampleModel/Name" />
          </XmlPropertyData>
          <XmlRelationshipData RoleElementName="exampleElements">
            <DomainRelationshipMoniker Name="ExampleModelHasExampleElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ExampleElement" MonikerAttributeName="name" SerializeId="true" MonikerElementName="exampleElementMoniker" ElementName="exampleElement" MonikerTypeName="ExampleElementMoniker">
        <DomainClassMoniker Name="ExampleElement" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="ExampleElement/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="description">
            <DomainPropertyMoniker Name="ExampleElement/Description" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="value">
            <DomainPropertyMoniker Name="ExampleElement/Value" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ExampleModelHasExampleElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleModelHasExampleElementsMoniker" ElementName="exampleModelHasExampleElements" MonikerTypeName="ExampleModelHasExampleElementsMoniker">
        <DomainRelationshipMoniker Name="ExampleModelHasExampleElements" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="modeling_testExplorer" />
  <CustomEditor CopyPasteGeneration="CopyPasteOnly" FileExtension="modelingtest" EditorGuid="c2c4da82-9d8a-4b5a-a5ed-072e77af6fef">
    <RootClass>
      <DomainClassMoniker Name="ExampleModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="modeling_testSerializationBehavior" />
    </XmlSerializationDefinition>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
  </CustomEditor>
  <Explorer ExplorerGuid="8fcaa8d5-ddc1-4a56-b4ef-4657563a7e18" Title="modeling_test Explorer">
    <ExplorerBehaviorMoniker Name="modeling_test/modeling_testExplorer" />
  </Explorer>
</Dsl>