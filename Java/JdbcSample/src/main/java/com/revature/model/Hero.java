package com.revature.model;

import java.util.jar.Attributes.Name;

public class Hero {
	
//	H_ID	        NOT NULL NUMBER	
//	H_NAME	                 VARCHAR2(100 BYTE)	
//	H_REAL_NAME	             VARCHAR2(100 BYTE)	
//	H_SUPER_POWER	NOT NULL VARCHAR2(100 BYTE)	
//	H_DOB	                 DATE	
//	H_GENDER	    NOT NULL VARCHAR2(20 BYTE)
//	U_ID	                 NUMBER	
	
	private long id;
	
	private String name;
	
	private String nrealName;
	
	private String superPower;
	/**
	 * You can represent a date as a String to reduce 
	 * complexity, if you don't need the actual date
	 * object.
	 * 
	 * LocalDateTime (Java 8 class)
	 */
	 
	//Should be a date in your projects but see strategy.
	
	private String dateOfBirth;
	
	private String gender;
	
	
	//DO NOT USE FK NUMERIC VALUES
	//private Universe universe;
	
}
