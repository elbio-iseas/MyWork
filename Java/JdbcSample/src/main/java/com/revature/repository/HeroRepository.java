package com.revature.repository;

import java.util.List;

import com.revature.model.Hero;

/**
 * 
 * his is the Hero DAO (Data Access Object).
 * 
 * -> Defines CRUD operations for this particular pojo.
 * -> NO BUSINESS LOGIC SHOULD BE PRESENT on these kind of
 * Objects.
 *
 */

public interface HeroRepository {
	
	public boolean create(Hero hero);
	
	public Hero findByName(String name);
	
	public List<Hero> findAll();
}
