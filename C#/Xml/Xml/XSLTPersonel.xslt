<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>

			</head>
			<body>
				<h1>Duz Gorunum</h1>
				<xsl:for-each select="insankaynaklari/personel">		
					<xsl:value-of select="adi"/>
				</xsl:for-each>
				<h2>Tablo Gorunum</h2>
				<table border="1">
					<tr>
						<th>Adi</th>
						<th>Soyadi</th>
					</tr>
					<xsl:for-each select="insankaynaklari/personel">
						<tr>
							<td>
								<xsl:value-of select="adi"/>
							</td>
							<td>
								<xsl:value-of select="soyadi"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
				Personel Sayisi:
				<xsl:value-of select="count(insankaynaklari/personel)"/>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
