package com.kdg.SchoolCup;

import android.app.ActionBar;
import android.app.Fragment;
import android.app.FragmentTransaction;

/**
 * Created with IntelliJ IDEA.
 * User: FezzFest
 * Date: 20/02/13
 * Time: 17:42
 * To change this template use File | SettingsFragment | File Templates.
 */

public class MyTabListener implements ActionBar.TabListener {
    public Fragment fragment;

    public MyTabListener(Fragment fragment) {
        this.fragment = fragment;
    }

    @Override
    public void onTabSelected(ActionBar.Tab tab, FragmentTransaction ft) {
        ft.replace(android.R.id.content, fragment);
    }

    @Override
    public void onTabUnselected(ActionBar.Tab tab, FragmentTransaction ft) {
        ft.remove(fragment);
    }

    @Override
    public void onTabReselected(ActionBar.Tab tab, FragmentTransaction ft) {
        // Do nothing when tab is reselected
    }
}