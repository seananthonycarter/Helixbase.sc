var ccSetup = {
  gtmId: 'GTM-KKGJ',
  ccKey: 'c17a57cf97d3d1fe2c91b24233bd51a2c08b5d98',
  liveDomain: 'sagittarius.agency'
}

function isLive(liveUrl) {
  return window.location.host === liveUrl;
}

(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer',ccSetup.gtmId);

var cccScript = document.createElement('script');
cccScript.src = 'https://cc.cdn.civiccomputing.com/9/cookieControl-9.x.min.js';

cccScript.onload = function() {

  var config = {
    position: 'LEFT',
    theme: 'LIGHT',
    apiKey: ccSetup.ccKey,
    product: 'COMMUNITY',
    necessaryCookies: [
      'wp_*',
      'word*',
      'wp-*',
      'wfwaf*',
      '__CFDUID', // Cloudflare security cookie
      '__stripe_mid',
      '__stripe_sid',
      'DYNSRV',
      'JSESSIONID',
      'NID',
      'PHPSESSID',
      'PYPF', // Paypal
      'wordfence_*',
      'wf*',
      'wc_*',
      'woo*',
      'wp_woo*'
    ],
    optionalCookies: [
      {
        name: 'performance',
        label: 'Performance',
        description: 'These cookies collect information about how visitors use a website and are used to provide better quality content and functionality. All information these cookies collect is aggregated and only used for statistical purposes.',
        cookies: [
          '_ga',
          '_gid',
          '_gat',
          '__utma',
          '__utmt',
          '__utmb',
          '__utmc',
          '__utmz',
          '__utmv',
          'Collect'
        ],
        initialConsentState: 'off',
        onAccept : function() {
          console.log('Performance Accepted');
          if (isLive(ccSetup.liveDomain)) {
            console.log('Performance On');
            dataLayer.push({'event': 'performance_on'}) // set this custom event in GTM as UA trigger
          } else {
            console.log('%cLocal or staging: analytics not loaded', 'color: orange');
          }
        },
        onRevoke: function() {
          console.log('Performance Rejected');
          window['ga-disable-'+ccSetup.gtmId] = true;
        }
      },
      {
        name: 'functionality',
        label: 'Functionality',
        description: 'These cookies allow the website to remember choices you make (such as your user name, language or the region you are in) and provide enhanced, more personal features. The information these cookies collect may be anonymised and they cannot track your browsing activity on other websites.',
        cookies: [],
        initialConsentState: 'off',
        onAccept : function() {},
        onRevoke: function() {}
      },
      {
        name: 'targeting-or-advertising',
        label: 'Targeting or Advertising',
        description: 'These types of cookies are set by digital advertising businesses for the prime or sole purpose of managing the performance of adverts, displaying adverts, and/or building user profiles to determine the display of adverts elsewhere.',
        cookies: [],
        initialConsentState: 'off',
        onAccept : function() {},
        onRevoke: function() {}
      },
    ]
  };

  CookieControl.load(config);

}

document.head.appendChild(cccScript);
