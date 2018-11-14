<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>The List</title>
      </head>
      <body>    
            <tr>
              <th>id</th>
              <th>name</th>
              <th>customer</th>
	<th>money</th>
              <th>phonenumber</th>
              <th>ordernumber</th>
            </tr>
<table>
        <xsl:apply-templates/>
    </table>    
   </body>
    </html>
  </xsl:template>
<xsl:template match="ArrayOfOrderDetail">
<xsl:apply-templates select="OrderDetail"/>
</xsl:template>
<xsl:template match="OrderDetail">
    <tr>
        <td valign="top">
            <xsl:value-of select="id"/>
        </td>
 	<td>
            <xsl:value-of select="name"/>
        </td>
 	<td>
            <xsl:value-of select="customer"/>
        </td>
 		<td>
            <xsl:value-of select="money"/>
        </td>
        <td valign="top">
            <xsl:value-of select="phonenumber"/>
        </td>
        <td>
            <xsl:value-of select="ordernumber"/>
        </td>
    </tr>
</xsl:template>

</xsl:stylesheet>