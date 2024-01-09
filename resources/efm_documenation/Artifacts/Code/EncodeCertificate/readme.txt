NOTE: The name of this solution is a misnomer.  It was initially created to merely demonstrate the creation of the tyl-efm-api HTTP header value, but was subsequently updated to also include submitting the HTTP transaction to retrieve a code resource from the EFM.

Usage:

EncodeCertificate.exe pfxpath pfxpassword apikeyout url saveto

	pfxpath 	- the path to your X.509 certifiate in PFX format
	pfxpassword - the password to open your PFX file
	apikeyout 	- the path+filename to create that will contain the value of the api header
	url			- fully qualified URL of the resource to download
	saveto		- the path+filename of where to save the downloaded zip file

	Example:
	EncodeCertificate c:\temp\mycert.pfx mypass c:\temp\apikey.txt https://server/codeservice/codes/location c:\temp\mylocations.zip
	
***************	
UPDATE 5/1/2017
***************

Remember that in order for your system to recognize/use the X.509 certificate Tyler issued to you, your system will need to trust the Tyler root certificate.  That certificate is included herein as tylerofsefmrootsha2.crt

***************	
UPDATE 5/5/2017
***************
Added a java based sample for generating the tyl-efm-api value