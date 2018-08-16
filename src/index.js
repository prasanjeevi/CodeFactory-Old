import $ from 'jquery'
import moment from 'moment'
import './css/styles.css'

$().ready(() => {
  let now = moment().format('YYYY-MM-DD');
  $('.clock').attr('datetime', now).text(now)
})