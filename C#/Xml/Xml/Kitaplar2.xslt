<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<body>
				<h2>Kitap Listesi</h2>
				<xsl:apply-templates></xsl:apply-templates>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="yazarlar">
		Yazar Adi:<span style="color:#ff0000">
			<xsl:value-of select="yazar"/>
		</span>

	</xsl:template>

	<xsl:template match="ad">
		Kitap Adi:<span style="color:#ff0000">
			<xsl:value-of select="."/>
		</span>
	</xsl:template>

	<xsl:template match="fiyat">
		Fiyati:<span style="color:#ff0000">
			<xsl:value-of select="."/>
		</span> <br/>
	</xsl:template>
</xsl:stylesheet>
