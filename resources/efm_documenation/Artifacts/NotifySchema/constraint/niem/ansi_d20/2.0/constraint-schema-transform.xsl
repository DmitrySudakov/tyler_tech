<xsl:stylesheet version="1.0" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="xml" encoding="UTF-8" indent="yes" />
<xsl:template match="xsd:enumeration[@value='1' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='2' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='3' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='4' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='5' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='9' and ../../@name='AccidentSeverityCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='A' and ../../@name='DriverLicenseClassCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='B' and ../../@name='DriverLicenseClassCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='C' and ../../@name='DriverLicenseClassCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='M' and ../../@name='DriverLicenseClassCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='B' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='C' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='D' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='E' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='F' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='G' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='I' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='J' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='K' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='L' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='O' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='W' and ../../@name='DrivingRestrictionCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='1' and ../../@name='HazMatCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='2' and ../../@name='HazMatCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:enumeration[@value='9' and ../../@name='HazMatCodeSimpleType']">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="/xsd:schema">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:complexType">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:simpleType">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:complexContent">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:extension">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:restriction">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:sequence">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:minInclusive">
<xsl:copy>
<xsl:for-each select="@*">
<xsl:copy />
</xsl:for-each>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:simpleContent">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="/xsd:schema/xsd:annotation">
<xsl:copy-of select="." />
</xsl:template>
<!-- <xsl:template match="/xsd:schema/xsd:complexType">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="/xsd:schema/xsd:simpleType">
<xsl:copy-of select="." />
</xsl:template> -->
<xsl:template match="/xsd:attribute/xsd:annotation">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="/xsd:attributeGroup/xsd:annotation">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:annotation" />
<xsl:template match="xsd:import">
<xsl:copy>
<xsl:attribute name="namespace">
<xsl:value-of select="@namespace" />
</xsl:attribute>
<xsl:attribute name="schemaLocation">
<xsl:value-of select="@schemaLocation" />
</xsl:attribute>
<xsl:apply-templates />
</xsl:copy>
</xsl:template>
<xsl:template match="xsd:attribute">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:attributeGroup">
<xsl:copy-of select="." />
</xsl:template>
<xsl:template match="xsd:element">
<xsl:copy-of select="." />
</xsl:template>
</xsl:stylesheet>
