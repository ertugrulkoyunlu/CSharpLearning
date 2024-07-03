<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<style>
					td{background-color:blue} 
				</style>
			</head>
			<body>
				<h2>Kitap Koleksiyonum</h2>
				<table border="1">
					<tr bgcolor="#cc6677">
						<th>numara</th>
						<th>kitapadi</th>
						<th>yazari</th>
					</tr>
					<!-- -->
					<xsl:for-each select="kitaplar/kitap">
						<tr>
							<td>
								<xsl:value-of select="numara"/>
							</td>
							<td>
								<xsl:value-of select="ad"/>
							</td>
							<td>
								<xsl:value-of select="yazarlar/yazar"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
