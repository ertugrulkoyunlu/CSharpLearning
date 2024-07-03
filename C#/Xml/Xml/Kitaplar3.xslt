<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<body style="background-color:#ccffcc">
				<xsl:for-each select="kitaplar/kitap">
					<div style="background-color:#66ccff;color:white">
						<xsl:value-of select="ad"/>
					</div>


					<div style="margin-left:20px;margin-bottom:1em;font-size:10pt">
						<xsl:value-of select="yazarlar/yazar"/>
						<xsl:value-of select="fiyat"/>
					</div>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
