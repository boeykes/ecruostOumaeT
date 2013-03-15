package com.kdg.SchoolCup;

import android.app.ActionBar;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;

public class MainActivity extends Activity {
    /**
     * Called when the activity is first created.
     */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        // Set application theme
        String theme = "light";
        if (theme.equals("light")) {
            setTheme(android.R.style.Theme_Holo_Light);
        } else {
            setTheme(android.R.style.Theme_Holo);
        }

        super.onCreate(savedInstanceState);

        // Create ActionBar
        final ActionBar actionBar = getActionBar();
        actionBar.setNavigationMode(ActionBar.NAVIGATION_MODE_TABS);

        // Home
        ActionBar.Tab tabHome = actionBar.newTab();
        tabHome.setText(getResources().getString(R.string.menu_home));
        tabHome.setTabListener(new MyTabListener(new Home()));
        actionBar.addTab(tabHome);

        // My School Cup
        ActionBar.Tab tabMySchoolCup = actionBar.newTab();
        tabMySchoolCup.setText(getResources().getString(R.string.menu_myschoolcup));
        tabMySchoolCup.setTabListener(new MyTabListener(new MySchoolCup()));
        actionBar.addTab(tabMySchoolCup);

        // Meetings
        ActionBar.Tab tabMeetings = actionBar.newTab();
        tabMeetings.setText(getResources().getString(R.string.menu_meetings));
        tabMeetings.setTabListener(new MyTabListener(new Meetings()));
        actionBar.addTab(tabMeetings);

        // Schools
        ActionBar.Tab tabSchools = actionBar.newTab();
        tabSchools.setText(getResources().getString(R.string.menu_schools));
        tabSchools.setTabListener(new MyTabListener(new Schools()));
        actionBar.addTab(tabSchools);

        // Photos
        ActionBar.Tab tabPhotos = actionBar.newTab();
        tabPhotos.setText(getResources().getString(R.string.menu_photos));
        tabPhotos.setTabListener(new MyTabListener(new Photos()));
        actionBar.addTab(tabPhotos);

        // Results
        ActionBar.Tab tabResults = actionBar.newTab();
        tabResults.setText(getResources().getString(R.string.menu_results));
        tabResults.setTabListener(new MyTabListener(new Results()));
        actionBar.addTab(tabResults);

        // No idea what this is doing
        if (savedInstanceState != null) {
            int savedIndex = savedInstanceState.getInt("SAVED_INDEX");
            getActionBar().setSelectedNavigationItem(savedIndex);
        }
    }

    // Options menu
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.options_menu, menu);
        return true;
    }

    // Handle item selection
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.new_event:
                return true;
            case R.id.settings:
                startActivity(new Intent(this, SettingsActivity.class));
                return true;
            case R.id.help:
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }
}
